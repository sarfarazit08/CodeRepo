from urllib.parse import urlparse

# Get domain name (example.com)


def get_domain(url):
    try:
        results = get_sub_domain(url).split('.')
        return results[-2] + '.' + results[-1]
    except:
        return ''

# Get sub domain name (name.example.com)


def get_sub_domain(url):
    try:
        return urlparse(url).netloc
    except:
        return ''