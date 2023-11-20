from graphics import *
import random


def create_window():
    win = GraphWin("Histogram", 800, 600)
    win.setBackground("Mint Cream")
    return win


def add_title_text_box(win):
    text_box = Text(Point(180, 50), "Histogram Results")
    text_box.setTextColor("grey")
    text_box.setSize(24)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_sub_title_text_box(win, outcomes_count):
    text_box = Text(Point(180, 560), f"{outcomes_count} outcomes in total.")
    text_box.setTextColor("grey")
    text_box.setSize(20)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_bar_count(win, x, y, count):
    text_box = Text(Point(x, y), count)
    text_box.setTextColor("grey")
    text_box.setSize(18)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_bar_title(win, x, y, title):
    text_box = Text(Point(x, y), title)
    text_box.setTextColor("grey")
    text_box.setSize(16)
    text_box.setStyle("bold")
    text_box.setFace("helvetica")
    text_box.draw(win)


def add_bar_graph_frame(win):
    rect = Rectangle(Point(50, 520), Point(750, 520))
    rect.draw(win)


def get_bar_width(count):
    return 605 / count - 5


def get_bar_height(bar_count, bar_total):
    return 420 * bar_count / bar_total


def get_bar_x(bar_index, bar_width):
    return 50 + 50 + bar_index * (bar_width + 5)


def get_random_color():
    return color_rgb(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)
    )


def add_bar_graph_bar(
    win, bar_index, bar_width, bar_count, max_bar_count, bar_total, title
):
    x = get_bar_x(bar_index, bar_width)
    y = 100
    height = get_bar_height(bar_count, max_bar_count)
    rect = Rectangle(Point(x, 520), Point(x + bar_width, 420 - height + y))
    rect.setFill(get_random_color())
    rect.draw(win)

    add_bar_count(win, x + bar_width / 2, 420 - height + y - 12, bar_count)
    add_bar_title(win, x + bar_width / 2, 533, title)


def main():
    outcomes_count = 40
    bar_count = 5
    bar_width = get_bar_width(bar_count)

    win = create_window()

    add_title_text_box(win)
    add_sub_title_text_box(win, outcomes_count)

    add_bar_graph_frame(win)

    add_bar_graph_bar(win, 0, bar_width, 14, 14, 40, "Progress")
    add_bar_graph_bar(win, 1, bar_width, 10, 14, 40, "Trailer")
    add_bar_graph_bar(win, 2, bar_width, 7, 14, 40, "Retre")
    add_bar_graph_bar(win, 3, bar_width, 2, 14, 40, "Laso")
    add_bar_graph_bar(win, 4, bar_width, 7, 14, 40, "Danny")

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
