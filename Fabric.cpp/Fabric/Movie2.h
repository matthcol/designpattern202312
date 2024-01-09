#pragma once
#include "IMovie.h"
#include <string>

class Movie2 : public IMovie
{
public:
	Movie2() = default;
	Movie2(const std::string& title, uint16_t year);
	virtual const std::string& title() const override;
	virtual void setTitle(const std::string& title) override;
	virtual uint16_t year() const override;
	virtual void setYear(uint16_t year) override;
	virtual std::string toString() const override;
private:
	std::string m_title;
	uint16_t m_year;
};



