#include "Movie.h"
#include <sstream>

Movie::Movie(const std::string& title, uint16_t year):
	m_title(title), m_year(year)
{
}

const std::string& Movie::title() const
{
	return m_title;
}

void Movie::setTitle(const std::string& title)
{
	m_title = title;
}

uint16_t Movie::year() const
{
	return m_year;
}

void Movie::setYear(uint16_t year)
{
	m_year = year;
}

std::string Movie::toString() const
{
	std::stringstream out;
	out << "Movie["
		<< m_title
		<< " ("
		<< m_year
		<< ")]";
	return out.str();
}
