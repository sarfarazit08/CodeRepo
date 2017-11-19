import numpy as np
from queue import Queue
from graph_adjacency_matrix import *

def breadth_first(graph, start=0):
    
    queue = Queue() # FIFO : First In First Out
    queue.put(start)

    visited = np.zeros(graph.numVertices)
    
    while not queue.empty():
        vertex = queue.get()
        
        if visited[vertex] == 1:
            continue
        
        print("Visited : ", vertex)
        
        visited[vertex] = 1
        
        for v in graph.get_adjacent_vertices(vertex):
            if visited[v] != 1:
                queue.put(v)
