#pragma once
#include "AbstractView.h"

class MyView: public AbstractView
{
public:
	~MyView();
protected:
	// from AbstractView
	void doDisplay() override;
};

