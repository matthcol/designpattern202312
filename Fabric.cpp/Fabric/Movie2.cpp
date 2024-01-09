#include "Movie2.h"
#include <sstream>

Movie2::Movie2(const std::string& title, uint16_t year) :
	m_title(title), m_year(year)
{
}

const std::string& Movie2::title() const
{
	return m_title;
}

void Movie2::setTitle(const std::string& title)
{
	m_title = title;
}

uint16_t Movie2::year() const
{
	return m_year;
}

void Movie2::setYear(uint16_t year)
{
	m_year = year;
}

std::string Movie2::toString() const
{
	// pattern Builder:
	// builder: std::stringstream
	std::stringstream out;
	// build: add Parts
	out << "SuperMovie["
		<< m_title
		<< " ("
		<< m_year
		<< ")]";
	// builder finisher
	return out.str();
}
