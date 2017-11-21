from queue import Queue
from graph_adjacency_matrix import *

def depth_first(graph, visited, current=0):    
    if visited[current] == 1:
        return
    
    visited[current] = 1

    print("Visited : ", current)
    
    for v in graph.get_adjacent_vertices(current):
        depth_first(graph,visited,v)
