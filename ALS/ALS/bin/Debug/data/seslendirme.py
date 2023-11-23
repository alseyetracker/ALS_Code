#!/usr/bin/env python
# -*- coding: utf-8 -*-


import os
import sys

mesaj = sys.argv[1]

from responsive_voice.voices import dil_id
dil=dil_id()


while True:
    try:
        dil.say(mesaj)
        break    
    except:
        print("Hata var.")

       

   





