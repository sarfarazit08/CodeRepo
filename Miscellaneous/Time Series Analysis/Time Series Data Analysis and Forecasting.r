### "Time Series Forcasting - Beverage"
### This notebook is about Time Series Forcasting and the data that we're using Beverage Data.

data = read.csv('./data/beverage-demo.csv',header = T, sep = ',')

### check the class
class(data)

### Display all the header columns
colnames(data)

### Display head data
head(data)


### Summary of the data
summary(data)

### Set 'OrderDate' column to date format 
Order.Date <- data$OrderDate
Order.Date<- as.Date(Order.Date, format = "%m / %d / %Y")

### Create a new data frame with only OrderDate and Quantity
modified.data <- data.frame(Order.Date, data$Quantity)
class(modified.data)

### find cummulative data
cummulative.data <- tapply(modified.data$data.Quantity, format(modified.data$Order.Date, '%m-%Y'), sum)

### check few records
head(cummulative.data)

### create a time series using the modified.data
ts.modified.data <- ts(modified.data, frequency = 12, start = c(2015), end = c(2018))

### check the class of time series data
class(ts.modified.data)

### plot the time series data
decomposedRes <- decompose(ts.modified.data, type="additive") # use type = "additive" for additive components
plot (decomposedRes) # see plot below
