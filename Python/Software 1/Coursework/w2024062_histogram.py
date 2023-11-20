from graphics import *
import random


def add_title_text_box(win):
    text_box = Text(Point(180, 50), "Histogram Results")
    text_box.setTextColor("grey")
    text_box.setSize(24)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_sub_title_text_box(win):
    text_box = Text(Point(180, 550), "33 outcomes in total.")
    text_box.setTextColor("grey")
    text_box.setSize(20)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_bar_count(win, index, count):
    text_box = Text(Point(180, 550), count)
    text_box.setTextColor("grey")
    text_box.setSize(18)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_bar_title(win, index, title):
    text_box = Text(Point(180, 550), title)
    text_box.setTextColor("grey")
    text_box.setSize(16)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_bar_graph_frame(win):
    rect = Rectangle(Point(50, 520), Point(750, 520))
    rect.draw(win)


def get_random_color():
    return color_rgb(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)
    )


def add_bar_graph_bar(win, bar_index, bar_width):
    x = 50 + 50 + bar_index * (bar_width + 5)
    y = 100
    max_height = 400
    rect = Rectangle(Point(x, 100), Point(x + bar_width, 100 + max_height))
    rect.setFill(get_random_color())
    rect.draw(win)


def main():
    win = GraphWin("Histogram", 800, 600)
    win.setBackground("Mint Cream")

    add_title_text_box(win)
    add_sub_title_text_box(win)

    add_bar_graph_frame(win)

    count = 5
    bar_width = 605 / count - 5

    add_bar_graph_bar(win, 0, bar_width)
    add_bar_graph_bar(win, 1, bar_width)
    add_bar_graph_bar(win, 2, bar_width)
    add_bar_graph_bar(win, 3, bar_width)
    add_bar_graph_bar(win, 4, bar_width)

    win.getMouse()


main()


# aCircle = Circle(
#     Point(150, 300), 100
# )  # Define circle: centre at 150px 300px radius is 100px.
# aCircle.draw(win)  # Render the circle to to the window


# b_Circle = Circle(Point(400, 300), 120)  # define a second circle
# b_Circle.setFill("Lime")
# b_Circle.setWidth(0)
# b_Circle.draw(win)  # Render the circle to to the window
