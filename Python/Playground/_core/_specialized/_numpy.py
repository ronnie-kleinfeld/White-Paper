import numpy as np

print(np.array([1, 2, 3]))  # [1 2 3]
print(type(np.array([1, 2, 3])))  # <class 'numpy.ndarray'>
array = np.array([[1, 2, 3], [4, 5, 6]])
print(array)  # [[1 2 3] [4 5 6]]
print(array.shape)  # (2, 3)
print(array[1, 1])  # 5

print(array > 3)  # [[False False False] [ True  True  True]]

print(np.sum(array))  # 21

print(np.zeros((2, 3), dtype=int))  # [[0 0 0] [0 0 0]]
print(np.ones((2, 3), dtype=int))  # [[1 1 1] [1 1 1]]
print(np.full((2, 3), 5, dtype=int))  # [[5 5 5] [5 5 5]]
print(
    np.random.random((2, 3))
)  # [[0.74496138 0.46319402 0.67394804] [0.22630732 0.4633108  0.56137582]]
