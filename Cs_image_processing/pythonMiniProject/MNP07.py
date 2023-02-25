import cv2
from PIL import Image
import math
import numpy as np
img = Image.open('lena.png')

Himg = Image.new(img.mode, img.size)
Simg = Image.new(img.mode, img.size)
Iimg = Image.new(img.mode, img.size)
HSIimg = Image.new(img.mode, img.size)

width,height = img.size
for x in range(width):
    for y in range(height):
        R,G,B = img.getpixel((x,y))
        t1 =  1/2*((R-G)+(R-B))
        t2 = math.sqrt((R-G)**2+(R-B)*(G-B)) 
        theta = math.acos(t1/t2)* 180/ math.pi
        if (B <= G):
             H = theta
        else :
            H = 360-theta
        S = 1 - 3/(R+G+B) * min([R,G,B])
        # rescale S
        S = S*255
        I = (R+G+B)/3
        Himg.putpixel((x,y),(int(H),int(H),int(H)))
        Simg.putpixel((x,y),(int(S),int(S),int(S)))
        Iimg.putpixel((x,y),(int(I),int(I),int(I)))
        HSIimg.putpixel((x,y),(int(I),int(S),int(H)))
Himg = np.array(Himg)
Simg = np.array(Simg)
Iimg = np.array(Iimg)
HSIimg = np.array(HSIimg)
imgCV2 = cv2.imread('lena.png')
cv2.imshow('Anh mau goc Lena', imgCV2)
cv2.imshow('kenh H Lena', Himg)
cv2.imshow('kenh S Lena', Simg)
cv2.imshow('kenh I Lena', Iimg)
cv2.imshow('Anh HSI Lena', HSIimg)
cv2.waitKey(0)
cv2.destroyAllWindows()
