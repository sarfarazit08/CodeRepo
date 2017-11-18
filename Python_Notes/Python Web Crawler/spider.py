from urllib.request import urlopen
from link_finder import LinkFinder
from general import *

class Spider:

    # Class variable shared among all spider instances
    project_name = ''
    base_url = ''
    domain_name = ''
    queued_file = ''
    crawled_file = ''
    queued = set()
    crawled = set()

    def __init__(self, project_name, base_url, domain_name):
        Spider.project_name = project_name
        Spider.base_url = base_url
        Spider.domain_name = domain_name
        Spider.queued_file = Spider.project_name + '/queued.txt'
        Spider.crawled_file = Spider.project_name + '/crawled.txt'
        self.boot()
        self.crawl_page('First Spider', Spider.base_url)

    @staticmethod
    def boot():
        '''
        boot()
        '''
        create_proj_folder(Spider.project_name)
        create_data_files(Spider.project_name, Spider.base_url)
        Spider.queued = file_to_set(Spider.queued_file)
        Spider.crawled = file_to_set(Spider.crawled_file)

    @staticmethod
    def crawl_page(thread_name, page_url):
        '''
        crawl_page(thread_name, page_url)
        '''
        if page_url not in Spider.crawled:
            print('Thread - {} crawling : {}'.format(thread_name, page_url))
            print('Queued - {} | Crawled - {}'.format(str(len(Spider.queued)),
                                                      str(len(Spider.crawled))))
            Spider.add_links_to_queue(Spider.gather_links(page_url))
            Spider.queued.remove(page_url)
            Spider.crawled.add(page_url)
            Spider.update_files()

    @staticmethod
    def gather_links(page_url):
        '''
        gather_links(page_url)
        '''
        html_string = ''
        try:
            response = urlopen(page_url) # ERROR in getting response
            if 'text/html' in response.getheader('Content-Type'):
                html_string = str(response.read())
            # Call LinkFinder class
            finder = LinkFinder(Spider.base_url, page_url)
            finder.feed(html_string)
        except Exception as e:
            print('Error : can not perform page crawling. {}'.format(e.args))
            return set()
        return finder.page_links()

    @staticmethod
    def add_links_to_queue(links):
        '''
        add_links_to_queue(links)
        '''
        for url in links:
            if url in Spider.queued:
                continue
            if url in Spider.crawled:
                continue
            if Spider.domain_name not in url:
                continue
            Spider.queued.add(url)

    @staticmethod
    def update_files():
        '''
        update_files()
        '''
        set_to_file(Spider.queued, Spider.queued_file)
        set_to_file(Spider.crawled, Spider.crawled_file)