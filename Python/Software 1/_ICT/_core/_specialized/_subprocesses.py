import subprocess

result = subprocess.run(["ls", "-l"])  # files in current directory
print(result)


subprocess.run("python3", "randoms.py")
