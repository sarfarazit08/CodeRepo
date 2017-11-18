'''
import modules
'''

import os


# Create a project folder

def create_proj_folder(folder):
    '''
    create_proj_folder (folder path)
    '''
    if not os.path.exists(folder):
        print('Creating project folder : {}'.format(folder))
        os.makedirs(folder)
        print('Created project folder : {}'.format(folder))


# Create Queue and Crawled Files

def create_data_files(project_name, base_url):
    '''
    create_data_files(project_name, base_url)
    '''
    queued_file = project_name + '/queued.txt'
    crawled_file = project_name + '/crawled.txt'
    if not os.path.isfile(queued_file):
        write_file(queued_file, base_url)
    if not os.path.isfile(crawled_file):
        write_file(crawled_file, '')

# Create a new file

def write_file(file_path, content):
    '''
    write_file(file_path, content)
    '''
    file = open(file_path, 'w')
    file.write(content)
    file.close()

# Append more content to file

def append_content(file_path, content):
    '''
    append_content(file_path, content)
    '''
    with open(file_path, 'a') as file:
        file.write(content + '\n')

# Delete file content

def delete_content(file_path):
    '''
    delete_content(file_path)
    '''
    with open(file_path, 'w'):
        pass

# Convert file to set

def file_to_set(file_path):
    '''
    file_to_set(file_path)
    '''
    links = set()
    with open(file_path, 'rt') as file:
        for line in file:
            links.add(line.replace('\n', ''))
    return links


# Convert set to file

def set_to_file(links, file_path):
    '''
    set_to_file(links, file_path)
    '''
    delete_content(file_path)
    for link in sorted(links):
        append_content(file_path, link)
