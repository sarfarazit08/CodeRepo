var datetime = new Date();

var hrs = datetime.getHours()
var mins = datetime.getMinutes()
var secs = datetime.getSeconds()
var day = datetime.getDate()
var month = datetime.getMonth()+ 1
var year = datetime.getFullYear()

document.write('DateTime : ', datetime)
document.write('<br />')
document.write('Time : ', hrs+":"+mins+":"+secs)
document.write('<br />')
document.write('Date : ', day+"-"+month+"-"+year)