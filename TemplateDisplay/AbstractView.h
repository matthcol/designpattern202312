#pragma once
class AbstractView
{
public:
	void display();
	virtual ~AbstractView(); // = default;
protected:
	virtual void doDisplay() = 0;
private:
	void setFocus();
	void resetFocus();
};

