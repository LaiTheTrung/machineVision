import cv2
import numpy as np

img = cv2.imread("lena.png")
print(img.shape)



#HUE
B=img[:,:,0]
G=img[:,:,1]
R =img[:,:,2]
t = 0.5*((R - G) + (R - B))
m = np.sqrt((R - G)**2.0 + (R - B)*(G - B))
theta = np.arccos(t/m)
print(theta)
theta = (180/np.pi)*theta
print(theta)
theta = theta.astype(np.uint8)
filt1 = B>G
filt2 = B<=G
H = filt1*(360-theta) + filt2*theta
H=H.astype(np.uint8)

#SATURATION
S = 1 - 3/np.sum(img,axis=-1) * np.min(img,axis =-1)
S = S*255
S = S.astype(np.uint8)

#INTENSITY
I =  np.sum(img,axis=2)/3
I = I.astype(np.uint8)
print(I)


#HSI
HSI = img.copy()
HSI[:,:,0]=I
HSI[:,:,1]=S
HSI[:,:,2]=H

cv2.imshow('Anh mau goc Lena', img)
cv2.imshow('kenh H Lena', H)
cv2.imshow('kenh S Lena', S)
cv2.imshow('kenh I Lena', I)
cv2.imshow('Anh HSI Lena', HSI.astype(np.uint8))
cv2.waitKey(0)


