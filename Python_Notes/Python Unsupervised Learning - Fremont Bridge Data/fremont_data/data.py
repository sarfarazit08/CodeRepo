import os
import pandas as pd
from urllib.request import urlretrieve

# Data url
FREMONT_URL = 'https://data.seattle.gov/api/views/65db-xm6k/rows.csv?accessType=DOWNLOAD'

def get_fremont_data(filename= 'Fremont.csv', url = FREMONT_URL, force_download=False):
	
	"""Download and cache Fremont Data
	
	Parameters
	----------
	filename : string (optional)
		Location to save the data
	url : string (optional)
		Web location of the data		
	force_download	: bool(optional)
		if True, Force re-download of data 
	
	Returns
	-------
	data : pandas.DataFrame
		The Fremont Bridge Data	
	"""	
	if force_download or not os.path.exists(filename):
		urlretrieve(url, 'Fremont.csv')
	
	# read csv file
	data = pd.read_csv('Fremont.csv', index_col='Date')
	
	# parse date column and use it as index column
	try:
		data.index = pd.to_datetime(data.index, format='%m/%d/%Y %I:%M:%S %p')
	except TypeError:
		data.index = pd.to_datetime(data.index)
	
	data.columns = ['West', 'East']
	# Sum of the counts of bicycles on East and West sides
	data['Total'] = data['West'] + data['East']
	return data