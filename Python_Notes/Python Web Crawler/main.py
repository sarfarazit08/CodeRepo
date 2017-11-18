'''
import modules
'''

import threading
from queue import Queue
import time

from spider import Spider
from domain import *
from general import *

PROJECT_NAME = 'pixels'
HOME_PAGE = 'https://www.pexels.com'
DOMAIN_NAME = get_domain(HOME_PAGE)
QUEUED_FILE = PROJECT_NAME + '/queued.txt'
CRAWED_FILE = PROJECT_NAME + '/crawled.txt'

THREAD_COUNT = 32

THREAD_QUEUE = Queue()
Spider(PROJECT_NAME, HOME_PAGE, DOMAIN_NAME)


# create worker threads (will die when main exits)
def create_workers():
    for _ in range(THREAD_COUNT):
        t = threading.Thread(target=work)
        t.daemon = True
        t.start()

# DO the next job in the queue

def work():
    while True:
        url = THREAD_QUEUE.get()
        Spider.crawl_page(threading.current_thread().name, url)
        THREAD_QUEUE.task_done()

# Each queued link is a new job

def create_jobs():
    for link in file_to_set(QUEUED_FILE):
        THREAD_QUEUE.put(link)
    THREAD_QUEUE.join()
    crawl()

# Check if there are items in the queue, if so crawl them

def crawl():    
    queued_links = file_to_set(QUEUED_FILE)
    if len(queued_links) > 0 :
        print(str(len(queued_links)) + ' links in the queue.')
        create_jobs()

print('Crawl started : {}'.format(str(time.strftime("%c"))))
create_workers()
crawl()
print('Crawl completed : {}'.format(str(time.strftime("%c"))))