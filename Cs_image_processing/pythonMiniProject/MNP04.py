import cv2
from PIL import Image
import matplotlib.pyplot as plt
import numpy as np

img = Image.open(r'lena.png')

lumi_const = np.array([0.2126,0.7152,0.0722]).reshape((1,1,3))
imgLumi= img*lumi_const
imgLumi =np.floor(np.sum(imgLumi,axis = -1))
imgLumi = np.uint8(imgLumi)
ret,imgLumi = cv2.threshold(imgLumi,100,255, cv2.THRESH_BINARY)
plt.imshow(imgLumi,cmap='gray')
plt.title('Binary')
plt.show()
