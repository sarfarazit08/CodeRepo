import os
import requests
from bs4 import BeautifulSoup


# image url parser
def parser(url):
    urls = set()    
    r = requests.get(url)
    data = r.text
    soup = BeautifulSoup(data, "lxml")
    for link in soup.find_all('img', {'class':'photo-item__img'}):
        image = link.get('srcset')
        image = image[:image.find("?")]
        urls.add(image)
    return urls

def file_download(storage_folder, urls):
    try:
        for url in urls:
            image_name = os.path.split(url)[1] 
            r2 = requests.get(url) 

            path = storage_folder+"\\"+image_name 
            with open(path, "wb") as f:
                f.write(r2.content)
        print('Files downloaded.')
    except Exception as e:
        print('Files download failed. {}'.format(e.args))
    
def write_html(storage_folder,urls):  
    links = []  
    
    for url in urls:
        links.append("<img src={} alt={} width='640px' height='360px' />".format(url,os.path.split(url)[1]))

    try:       
        path = storage_folder+"\images.html" 
        file = open(path,'w')
        file.write('\n'.join(links))
        file.close()
        print("File writing successful.")
    except IOError as e:
        print("File writing failed. {}" % e)
        file.close()

# Create project storage folder
def create_proj_folder(storage_folder):
    '''
    create_proj_folder (storage_folder)
    '''
    if not os.path.exists(storage_folder):
        print('Creating project folder : {}'.format(storage_folder))
        os.makedirs(storage_folder)
        print('Created project folder : {}'.format(storage_folder))

# main method
def main(url, storage_folder):

    urls = set() 

    # image url parser
    urls = parser(url)

    # Create image storage folder
    create_proj_folder(storage_folder)

    # Download all the images
    file_download(storage_folder,urls)        
    
    # write the link in html file
    write_html(storage_folder,urls)   

# Calling main method
keys = ['nature', 'beach', 'monuments']
    
i=0
for key in keys :
    i += 1
    folder = 'models_'+str(i)
    url = 'https://www.pexels.com/search/'+ key
    main(url, folder)