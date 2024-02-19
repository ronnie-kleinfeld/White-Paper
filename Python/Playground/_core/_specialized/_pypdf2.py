import os
from PyPDF2 import PdfReader

path = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))
file_name = os.path.join(path, "_pypdf2sample.pdf")
print(file_name)

reader = PdfReader(file_name)
print(len(reader.pages))
print(reader.pages[0])
