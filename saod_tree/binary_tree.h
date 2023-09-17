#pragma once
#include <iostream>

// шаблонная структура узла бинарного дерева
template<typename T>
struct Node {
     T data;
     Node* left;
     Node* right;

    Node() {
        left = nullptr;
        right = nullptr;
    }
//

};

// конструктор 
template<typename T>
Node<T>* newNode(T data) {
    Node<T>* node = new Node<T>; // адрес этого узла сохраняется в указателе node.

    node->data = data; 

    node->left = nullptr; //  устанавливаются в nullptr, чтобы указать, что у созданного узла пока нет левого и правого поддеревьев
    node->right = nullptr;
    return node;
}

// вывод дерева в порядке главный узел, левая ветка, правая ветка NLR
template<typename T>
void traversePreOrder(Node<T>* temp) {
    if (temp != nullptr) {
        std::cout << " " << temp->data;
        traversePreOrder(temp->left);
        traversePreOrder(temp->right);
    }
}

// вывод дерева в порядке левая ветка, главный узел, правая ветка LNR
template<typename T>
void traverseInOrder(Node<T>* temp) {
    if (temp != nullptr) {
        traverseInOrder(temp->left);
        std::cout << " " << temp->data;
        traverseInOrder(temp->right);
    }
}

// вывод дерева в порядке левая ветка, правая ветка, главный узел LRN
template<typename T>
void traversePostOrder(Node<T>* temp) {
    if (temp != nullptr) {
        traversePostOrder(temp->left);
        traversePostOrder(temp->right);
        std::cout << " " << temp->data;
    }
}

// удаление узлов
template<typename T>
void deleteNode(Node<T>* temp) {
    if (temp != nullptr) {
        deleteNode(temp->left);
        deleteNode(temp->right);
        free(temp);
    }
}

//подсчет узлов
template<typename T>
int countNodes(Node<T>* root) {
    if (root == nullptr) {
        // Если дерево пусто (корень равен nullptr), возвращаем 0.
        return 0;
    } else {
        // Иначе, рекурсивно считаем количество узлов в левом и правом поддеревьях,
        // а затем добавляем 1 для текущего узла (корня).
        return 1 + countNodes(root->left) + countNodes(root->right);
    }
}


///         1
///        /        
///       2   3
///      /   / \
///     4   9  15

// полезно https://medium.com/@dimko1/алгоритмы-обход-дерева-ed54848c2d47




