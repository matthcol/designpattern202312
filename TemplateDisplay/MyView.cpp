#include "MyView.h"
#include <iostream>

MyView::~MyView()
{
	std::clog << "MyView destructed" << std::endl;
}

void MyView::doDisplay()
{
	// render the view's contents
	std::cout << "MyView::doDisplay\n";
}
