import cv2
from PIL import Image
import matplotlib.pyplot as plt
import numpy as np
fig,axes = plt.subplots(nrows = 1, ncols = 3, figsize=(10,10))

img = Image.open(r'bird_small.jpg')
# average
img = np.array(img)
imgA =np.floor(np.sum(img,axis = -1)/3)
imgA = np.uint8(imgA)
axes[0].imshow(imgA,cmap='gray')
axes[0].title.set_text('Average grayscale')

# lightness
imgL = np.max(img,axis=-1)
axes[1].imshow(imgL,cmap='gray')
axes[1].title.set_text('Lightness grayscale')

# luminiance
lumi_const = np.array([0.2126,0.7152,0.0722]).reshape((1,1,3))
imgLumi= img*lumi_const
imgLumi =np.floor(np.sum(imgLumi,axis = -1))
imgLumi = np.uint8(imgLumi)

axes[2].imshow(imgLumi,cmap='gray')
axes[2].title.set_text('Luminiance grayscale')
plt.show()