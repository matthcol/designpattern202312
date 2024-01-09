#pragma once
#include <iostream>
#include <string>
class IMovie
{
public:
	virtual const std::string& title() const = 0;
	virtual void setTitle(const std::string& title) = 0;
	virtual uint16_t year() const = 0;
	virtual void setYear(uint16_t year) = 0;
	virtual std::string toString() const = 0;
};

std::ostream& operator<<(std::ostream& out, const IMovie& movie);

