import priority_dict
from graph_adjacency_matrix import *

def spanning_tree(graph, source):
    
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
            
    # To track visted vertices            
    visited_vertices = set()

    # Set of edges where each edge is represented as a string
    # "1->2": is an edge between vertices 1 and 2
    spanning_tree = set()

    while len(priority_queue.keys()) > 0:
        current_vertex = priority_queue.pop_smallest()

        # If we've already visited a vertex then we've all
        # outbound edges from it, we do not process it again
        if current_vertex in visited_vertices:
            continue

        # add unvisited vertext to result set
        visited_vertices.add(current_vertex)

        # If the current vertex is the source, we haven't traversed
        # an edge yet, no edge to add to our spanning tree
        if current_vertex != source:
            # The current vertex is connected by the lowest weighted edge
            last_vertex = distance_table[current_vertex][1]

            edge = str(last_vertex) + "->" + str(current_vertex)

            if edge not in spanning_tree:
                spanning_tree.add(edge)


        for neighbor in graph.get_adjacent_vertices(current_vertex):
            distance =  graph.get_edge_weight(current_vertex,neighbor)

            # The last recorded distance of this neighbor from the source
            neighbor_distance = distance_table[neighbor][0]

            # If there is a currently recorded distance from the source and this is
            # greater than the distance of the new path found, update the current distance
            # from the source in the distance table
            if neighbor_distance is None or neighbor_distance > distance:
                distance_table[neighbor] = (distance, current_vertex)
                priority_queue[neighbor] = distance
                    
    for edge in spanning_tree:
        print(edge)
