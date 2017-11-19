from queue import Queue
from graph_adjacency_set import *

def build_distance_table(graph, source):
    
    # A dictionary mapping from the vertex number to tuple
    # of (distance from source, preceding node)
    distance_table = {}    
        
    for i in range(graph.numVertices):
        distance_table[i] = (None,None)
        
    # The distance to the source from itself is 0 (zero)
    distance_table[source] = (0, source)
     
    queue = Queue() # FIFO : First In First Out
    queue.put(source)
            
    while not queue.empty():
        current_vertex = queue.get()

        # The distance of the current vertex from the source
        current_distance = distance_table[current_vertex][0]
        
        for neighbor in graph.get_adjacent_vertices(current_vertex):
            # only update the distance table if 
            # no current distance from the source is set
            if distance_table[neighbor][0] is None:
                distance_table[neighbor] = (1 + current_distance, current_vertex)
                
                # Enqueue the neighbor only if it has 
                # other adjacent vertices to explore
                
                if len(graph.get_adjacent_vertices(neighbor)) > 0 :
                    queue.put(neighbor)
                    
                    
    return distance_table
    
def shortest_path(graph, source, destination):
    distance_table = build_distance_table(graph, source)        
    
    path = [destination]
    
    previous_vertex = distance_table[destination][1]
    
    while previous_vertex is not None and previous_vertex is not source:
       
        path = [previous_vertex] + path
       
        previous_vertex = distance_table[previous_vertex][1]
        
    if previous_vertex is None:
        print("There is no path from %d to %d" % (source, destination))
    else:
        path = [source] + path
        print ("Shortest path :", path)
