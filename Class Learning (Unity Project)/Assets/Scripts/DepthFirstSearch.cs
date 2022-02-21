using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{

    public Node rootNode;
    public Node target;

    private void Start()
    {
        int stepCount = DFS(target);
        if(stepCount > -1)
        {
            Debug.Log(target.name + " was found in " + stepCount + " steps.");
        }
        else
        {
            Debug.Log(target.name + " was found not found.");
        }
    }
    public int DFS(Node targetNode)
    {
        Stack stack = new Stack();  //stack the nodes, the last one stacked is the first one visited
        List<Node> visitedNodes = new List<Node>(); //tracks the visited nodes
        visitedNodes.Add(rootNode);
        stack.Push(rootNode); //push the root node to the stack

        while (stack.Count > 0) //while the stack is not empty
        {
            Node node = (Node)stack.Pop();  //get the last stacked node
            Debug.Log("Checking: " + node.name); //visit the node
            foreach (Node child in node.children) //Loop through the children of node
            {
                //if the child has not been visited
                if(visitedNodes.Contains(child) == false)
                {
                    Debug.Log("Checking Child" + child.name + " of node " + node.name);
                    if(child == targetNode) //target node found
                    {
                        Debug.Log("Target " + child.name + " found");
                        return visitedNodes.Count;  //return number of visited nodes
                    }
                    stack.Push(child);
                }
            }
        }
        return -1;
    }
}
