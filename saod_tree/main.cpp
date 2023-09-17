#include <stdlib.h>
#include <iostream>
#include <exception>
#include "binary_tree.h"


using namespace std;




int main() {
    Node<int>* root = newNode<int>(1);
    root->left = newNode(2);
    root->right = newNode(3);
    root->right->left = newNode(9);
    root->left->left = newNode(4);
    root->right->right = newNode(15);
    std::cout << "preorder: ";
    traversePreOrder(root);
    std::cout << "\nInorder: ";
    traverseInOrder(root);
    std::cout << "\nPostorder: ";
    traversePostOrder(root);

    deleteNode(root);



///         1
///        /        
///       2   3
///      /   / \
///     4   9  15

}