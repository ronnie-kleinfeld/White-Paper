from tkinter import *
from tkinter import ttk

root = Tk()
root.title("Hello")
frame = ttk.Frame(root, padding="10 10 10 10")
ttk.Button(root, text="Hello World").grid()
root.mainloop()
