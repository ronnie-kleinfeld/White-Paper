import random
from graphics import GraphWin
from graphics import Text
from graphics import Point
from graphics import Rectangle
from graphics import color_rgb


def add_window():
    win = GraphWin("Histogram", 800, 600)
    win.setBackground("Mint Cream")
    return win


def add_title_text_box(win):
    add_text_box(win, 180, 50, "Histogram Results", "grey", 24, "bold", "helvetica")


def add_sub_title_text_box(win, outcomes_count):
    title = f"{outcomes_count} outcomes in total."
    add_text_box(win, 180, 560, title, "grey", 20, "bold", "helvetica")


def add_bar_count_text_box(win, x, y, count):
    add_text_box(win, x, y, count, "grey", 18, "bold", "helvetica")


def add_bar_title_text_box(win, x, y, title):
    add_text_box(win, x, y, title, "grey", 16, "bold", "helvetica")


def add_text_box(win, x, y, title, text_color, size, style, face):
    text_box = Text(Point(x, y), title)
    text_box.setTextColor(text_color)
    text_box.setSize(size)
    text_box.setStyle(style)
    text_box.setFace(face)
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


def add_bar_graph_bar(win, bar_index, bar_width, bar_count, max_bar_count, title):
    x = get_bar_x(bar_index, bar_width)
    y = 100
    height = get_bar_height(bar_count, max_bar_count)
    rect = Rectangle(Point(x, 520), Point(x + bar_width, 420 - height + y))
    rect.setFill(get_random_color())
    rect.draw(win)

    add_bar_count_text_box(win, x + bar_width / 2, 420 - height + y - 12, bar_count)
    add_bar_title_text_box(win, x + bar_width / 2, 533, title)


def test_histogram():
    progression_summary = {}
    progression_summary["Progress"] = 9
    progression_summary["Trailer"] = 3
    progression_summary["Retriever"] = 6
    progression_summary["Exclude"] = 2
    progression_summary["Special"] = 0
    show_histogram(progression_summary)


def show_histogram(progression_summary):
    outcomes_count = 0
    bar_count = 0
    max_bar_value = 0
    for key, value in progression_summary.items():
        if value > max_bar_value:
            max_bar_value = value
        outcomes_count += value
        bar_count += 1

    bar_width = get_bar_width(bar_count)

    win = add_window()

    add_title_text_box(win)
    add_sub_title_text_box(win, outcomes_count)

    add_bar_graph_frame(win)

    index = 0
    for key, value in progression_summary.items():
        add_bar_graph_bar(win, index, bar_width, value, max_bar_value, key)
        index += 1

    win.getMouse()


# test_histogram()
