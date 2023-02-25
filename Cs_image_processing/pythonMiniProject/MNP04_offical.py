import cv2
from PIL import Image
import matplotlib.pyplot as plt
import numpy as np

img = Image.open('lena.png')
def empty():
    pass
# create a trackbar to change threshold value
binary = Image.new(img.mode, img.size)
cv2.namedWindow("trackbars") # create window
cv2.resizeWindow("trackbars",640,240)
cv2.createTrackbar("Threshold","trackbars",110,255,empty)
#create blank image to convert RGB to binary
while True:
    threshold= cv2.getTrackbarPos("Threshold","trackbars")
    #take the size of image
    width,height = binary.size
    for x in range(width):
        for y in range(height):
            R,G,B = img.getpixel((x,y))
            gray = np.uint8(0.2126*R+0.7152*G+0.0722*B)
            bin = 255*(gray > threshold) 
            binary.putpixel((x,y),(bin,bin,bin))
    Binary = np.array(binary)

    imgCV2 = cv2.imread('lena.png')
    cv2.imshow('Anh mau goc Lena', imgCV2)
    cv2.imshow('Anh binaery Lena',Binary)
    if cv2.waitKey(1) & 0xFF==ord('e'):
        break

