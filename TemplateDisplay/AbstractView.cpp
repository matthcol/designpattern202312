#include "AbstractView.h"
#include <iostream>

void AbstractView::display()
{
    setFocus();
    doDisplay(); // abstract step
    resetFocus();
}

AbstractView::~AbstractView()
{
    std::clog << "AbstractView destructed" << std::endl;
}

void AbstractView::setFocus() {
    std::cout << "View::setFocus\n";
}
void AbstractView::resetFocus() {
    std::cout << "View::resetFocus\n";
}
