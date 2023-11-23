#Not: opencv ile okunan tüm resimler, video kareleri BGR renk formatındadır.


#kütüphaneleri yükle
import win32gui
import win32con
import cv2
import mediapipe as mp
import math
import numpy as np
import pyautogui

mp_face_mesh = mp.solutions.face_mesh

sayac,sayacy,sayaca,sayacsag,sayacsol = 0,0,0,0,0
uyku_kontrol = False

iris = [469, 470, 471, 472]
goz = [160,144,158,153,33,133,52,119]

def uyku():       
    return win32gui.SendMessage(win32con.HWND_BROADCAST,
        win32con.WM_SYSCOMMAND, win32con.SC_MONITORPOWER, 2)


def iris_takip():
    global center
    (x,y),radius = cv2.minEnclosingCircle(kor[iris])
    center = (int(x),int(y))
    radius = int(radius)
    cv2.circle(foto_kare,center,2,(0,0,255),-1)



#web kamerasından görüntü yakala
kamera = cv2.VideoCapture(kamera_id)

with mp_face_mesh.FaceMesh(
    max_num_faces=1,
    refine_landmarks=True,
    min_detection_confidence=0.5,
    min_tracking_confidence=0.5) as face_mesh:

  while True:
    durum, foto_kare = kamera.read()
    
    #fotoğraf karesini yatayda ters çevir
    foto_kare = cv2.flip(foto_kare, 1)

    #fotoğraf karesinin yükseklik ve genişliğini bul
    yuk, gen = foto_kare.shape[:2]

    if durum==False:   
      print("kamera bağlantı hatası")
      continue # düngünün başına dön

    # Performansı artırmak için resim üzerine yazma olmasın
    foto_kare.flags.writeable = False
    #opencv ile okunan her fotoğraf karesi BGR formatındadır.Mediapipe RGB formatında çalışır.
    #RGB'yi BGR'ye çevirme
    foto_kare = cv2.cvtColor(foto_kare, cv2.COLOR_BGR2RGB)
    results = face_mesh.process(foto_kare)

    # Çizim işlmine hazırlanılıyor
    foto_kare.flags.writeable = True
    foto_kare = cv2.cvtColor(foto_kare, cv2.COLOR_RGB2BGR)

    if results.multi_face_landmarks:

      kor=np.array([np.multiply([p.x, p.y], [gen, yuk]).astype(int) for p in results.multi_face_landmarks[0].landmark])
      
      iris_takip()

      A = (math.dist(kor[goz[0]],kor[goz[1]]))
      B = (math.dist(kor[goz[2]],kor[goz[3]]))
      C = (math.dist(kor[goz[4]],kor[goz[5]]))
      D = (math.dist(kor[goz[6]],kor[goz[7]]))
      E = (math.dist(center,kor[goz[7]]))#dikey mesafe
      F = (math.dist(center,kor[goz[4]]))#yatay mesafe
      goz_oran = (A+B)/(2*C)
      dikey_oran = D/E
      yatay_oran= C/F
      
      if dikey_oran < 1.62 and yatay_oran > 1.8:
          sayacy += 1          
          if sayacy==10:
              pyautogui.moveRel(0,-50)
              sayacy= 0
      
      elif dikey_oran > 2 and yatay_oran < 2.8 and sayac < 2:
          sayaca += 1          
          if sayaca==10:
              pyautogui.moveRel(0, 50)
              sayaca=0
         
          
      elif yatay_oran < 1.8 and dikey_oran < 2:
          sayacsag += 1
          
          if sayacsag==10:
              pyautogui.moveRel(50, 0)
              sayacsag=0

              
      elif yatay_oran > 2.8:
          sayacsol += 1          
          if sayacsol==10:
              pyautogui.moveRel(-50, 0)
              sayacsol=0
      else:
          sayacy,sayacsag,sayacsol,sayaca = 0,0,0,0
          
      
      if goz_oran>=0.15:
        sayac = 0
        if uyku_kontrol:
            pyautogui.press("enter")
            uyku_kontrol = False
            
        
      elif goz_oran<=0.15 and sayaca < 1:
        sayac += 1
        
        if (sayac == 25):
            pyautogui.click()
        elif (sayac == 100):
            uyku()
            uyku_kontrol = True
        

      print("Sayaç: ",sayac)

    #cv2.imshow('MediaPipe Face Mesh', foto_kare)
    if cv2.waitKey(5) & 0xFF == 27: #esc tuşuna basılınca
      break #döngüyü kır

kamera.release()#kamerayı serbest bırak
cv2.destroyAllWindows()#tüm pencereleri kapat
