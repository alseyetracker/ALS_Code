#Not: opencv ile okunan tüm resimler, video kareleri BGR renk formatındadır.


#kütüphaneleri yükle
import win32gui
import win32con
import cv2
import mediapipe as mp
import math
import numpy as np
import pyautogui
from playsound import playsound
import sys
import webbrowser

mp_face_mesh = mp.solutions.face_mesh



goz = [123,352,197]


def cizim(deger):
      cv2.rectangle(foto_kare,(0,0),(1280,720),deger,10)
      cv2.rectangle(foto_kare,(0,600),(1280,720),deger,-1)
      cv2.rectangle(foto_kare,(int((gen/2) -220),int((yuk/2) -220)),(int((gen/2) +220),int((yuk/2) +220)),deger,3)
      font = cv2.FONT_HERSHEY_SIMPLEX

      cv2.putText(foto_kare,"+", (600,390), font, 3, (255,255,255), 4, cv2.LINE_AA)
      cv2.putText(foto_kare,f"Distance: {int(uzaklik)}cm / Save by pressing ESC", (300,670), font, 1, (255,255,255), 3, cv2.LINE_AA)
  
#web kamerasından görüntü yakala
kamera = cv2.VideoCapture(kamera_id, cv2.CAP_DSHOW) # this is the magic!

#yükseklik genişlik ayarla
kamera.set(cv2.CAP_PROP_FRAME_WIDTH, 1280)
kamera.set(cv2.CAP_PROP_FRAME_HEIGHT, 720)



with mp_face_mesh.FaceMesh(
    max_num_faces=1,
    refine_landmarks=True,
    min_detection_confidence=0.5,
    min_tracking_confidence=0.5) as face_mesh:

  #webbrowser.open("kamera_ayar.mp3")
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
    

      A = (math.dist(kor[goz[0]],kor[goz[1]])) #Gözün altında iki nokta arası uzaklık
      B = math.dist(kor[goz[2]],(int(gen/2),int(yuk/2))) #Burun merkez ortalama

      #cv2.line(foto_kare,kor[goz[0]], kor[goz[1]], (0,0,255), 2)
      cv2.circle(foto_kare,kor[goz[2]],10, (255,255,255), -1)
      
      uzaklik = (354*30)/A
      #print(uzaklik,A,B)

      if (uzaklik>30 and uzaklik <50)and (B<35):
        cizim((0,255,0))
      else:
        cizim((0,0,255))
      
    cv2.imshow('Kamera Ayarlari', foto_kare)
    
    if cv2.waitKey(5) & 0xFF == 27: #esc tuşuna basılınca
      break #döngüyü kır

kamera.release()#kamerayı serbest bırak
cv2.destroyAllWindows()#tüm pencereleri kapat
