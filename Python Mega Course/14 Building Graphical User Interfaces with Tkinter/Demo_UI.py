from tkinter import *

window = Tk()

def display():
	#print(entry_val.get())
	txtBox.insert(END,entry_val.get()+"\n")

btn = Button(window, text = "Run", command = display)
btn.grid(row=0, column=0)

entry_val = StringVar()
entry = Entry(window,textvariable=entry_val)
entry.grid(row=0, column=1)

txtBox = Text(window)
txtBox.grid(row=0, column=2)


window.mainloop()



	
