from graphics import *  # import the graphics.py module (must be in the same folder this file)


# OPEN THE WINDOW
win = GraphWin(
    "My First Graphics Window", 800, 600
)  # open a window object called "win" with size and title
win.setBackground("Mint Cream")  # Set the background colour of the window


my_heading = Text(Point(140, 30), "Here is My Heading")  # Define some text.
my_heading.draw(win)  # Render text to our window.

aCircle = Circle(
    Point(150, 300), 100
)  # Define circle: centre at 150px 300px radius is 100px.
aCircle.draw(win)  # Render the circle to to the window


# style the heading
my_heading.setTextColor("grey")
my_heading.setSize(24)
my_heading.setStyle("bold")
my_heading.setFace("helvetica")


my_sub_heading = Text(Point(140, 60), "Here is My Subheading")  # Define the text
# style the  subheading
my_sub_heading.setTextColor("grey")
my_sub_heading.setSize(20)
my_sub_heading.setStyle("bold")
my_sub_heading.setFace("helvetica")
my_sub_heading.draw(win)  # Render text to the window

b_Circle = Circle(Point(400, 300), 120)  # define a second circle
b_Circle.setFill("Lime")
b_Circle.setWidth(0)
b_Circle.draw(win)  # Render the circle to to the window
win.getMouse()
