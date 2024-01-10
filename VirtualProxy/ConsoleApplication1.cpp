// ConsoleApplication1.cpp : Ce fichier contient la fonction 'main'. L'exécution du programme commence et se termine à cet endroit.
//

#include <iostream>
#include <utility>
#include "Matrix.h"
#include "ProxyMatrix.h"
#include "IMatrix.h"

int main()
{
    auto m_ptr = std::shared_ptr<Matrix>(new Matrix(5,5));
    std::pair<size_t, size_t>  coords(3, 4);
    (*m_ptr)[coords] = 5.75;
    std::cout << (*m_ptr)[coords] << std::endl;
    m_ptr->fill_randomly();
    double s = m_ptr->sum(3);
    std::cout << "Sum row #3: " << s << std::endl;
    for (size_t j = 0; j < 5; j++) std::cout << (*m_ptr)[{3, j}] << " ";
    std::cout << std::endl;

    
    std::cout << (*m_ptr)[{3, 3}] << std::endl;
    std::unique_ptr<IMatrix> proxy(new ProxyMatrix(m_ptr));
    std::cout << (*proxy)[{3, 3}] << std::endl;
    std::cout << (*proxy)[{3, 4}] << std::endl;
    std::cout << proxy->sum(3) << std::endl;
    std::cout << proxy->sum(4) << std::endl;
}

// Exécuter le programme : Ctrl+F5 ou menu Déboguer > Exécuter sans débogage
// Déboguer le programme : F5 ou menu Déboguer > Démarrer le débogage

// Astuces pour bien démarrer : 
//   1. Utilisez la fenêtre Explorateur de solutions pour ajouter des fichiers et les gérer.
//   2. Utilisez la fenêtre Team Explorer pour vous connecter au contrôle de code source.
//   3. Utilisez la fenêtre Sortie pour voir la sortie de la génération et d'autres messages.
//   4. Utilisez la fenêtre Liste d'erreurs pour voir les erreurs.
//   5. Accédez à Projet > Ajouter un nouvel élément pour créer des fichiers de code, ou à Projet > Ajouter un élément existant pour ajouter des fichiers de code existants au projet.
//   6. Pour rouvrir ce projet plus tard, accédez à Fichier > Ouvrir > Projet et sélectionnez le fichier .sln.
