import priority_dict
from graph_adjacency_matrix import *

def build_distance_table(graph, source):
    
    # A dictionary mapping from the vertex number to tuple
    # of (distance from source, preceding node)
    distance_table = {}    
        
    for i in range(graph.numVertices):
        distance_table[i] = (None,None)
        
    # The distance to the source from itself is 0 (zero)
    distance_table[source] = (0, source)
     
    # Holds Mapping of vertex id to distance from source
    # Access the High Priority (Lowest Distance) item first
    priority_queue = priority_dict.priority_dict()
    priority_queue[source] = 0
            
    while len(priority_queue.keys()) > 0:
        current_vertex = priority_queue.pop_smallest()

        # The distance of the current node from the source
        current_distance = distance_table[current_vertex][0]
        
        for neighbor in graph.get_adjacent_vertices(current_vertex):
            distance =  current_distance + graph.get_edge_weight(current_vertex,neighbor)

            # The last recorded distance of this neighbor from the source
            neighbor_distance = distance_table[neighbor][0]

            # If there is a currently recorded distance from the source and this is
            # greater than the distance of the new path found, update the current distance
            # from the source in the distance table
            if neighbor_distance is None or neighbor_distance > distance:
                distance_table[neighbor] = (distance, current_vertex)
                priority_queue[neighbor] = distance
                    
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
