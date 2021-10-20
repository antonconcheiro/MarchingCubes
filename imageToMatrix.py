import cv2
import numpy
import os, os.path
import imghdr
import re

acceptedTypes=['png','jpg','jpeg']

def atoi(text):
    return  int(text) if text.isdigit() else text

def natural_keys(text):
    return [atoi(c) for c in re.split(r'(\d+)', text)]

def processImages():
    imgFiles = [name for name in os.listdir('./images') if imghdr.what('./images/'+name) in acceptedTypes]
    imgFiles.sort(key=natural_keys)
    print(imgFiles)
    index = 0
    for image in imgFiles:
        print(index, 'Image=')
        image='./images/'+image
        print(image)

        img = cv2.imread(image,0)
        crop_img = img[:, 0:0 + 480]
        print(numpy.shape(crop_img))
        print(crop_img[120,240])
        numpy.savetxt('./output/'+(str(index)+'output.txt'),crop_img,fmt="%i")
        index+=1
        print("")

if __name__ == "__main__":
    processImages()