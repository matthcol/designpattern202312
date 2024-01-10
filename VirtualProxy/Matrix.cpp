#include "Matrix.h"
#include <numeric>
#include <random>

Matrix::Matrix(size_t m, size_t n): m_m(m), m_n(n)
{
	m_data = new double[m * n];
}

Matrix::~Matrix()
{
	delete[] m_data;
}

size_t Matrix::m() const
{
    return m_m;
}

size_t Matrix::n() const
{
    return m_n;
}

double Matrix::operator[](std::pair<size_t, size_t> coords) const
{
	return m_data[coords.first*m_n + coords.second];
}

double& Matrix::operator[](std::pair<size_t, size_t> coords)
{
	return m_data[coords.first * m_n + coords.second];
}

double Matrix::sum(size_t row) const
{
	auto first = m_data + row * m_n;
	return std::accumulate(first, first + m_n, 0.0);;
}

void Matrix::fill_randomly()
{
    std::random_device rd{};
    std::mt19937 gen{ rd() };

    // values near the mean are the most likely
    // standard deviation affects the dispersion of generated values from the mean
    std::normal_distribution<double> d{ 12.0, 3.0 };

    // draw a sample from the normal distribution and round it to an integer
    // auto random_int = [&d, &gen]{ return std::round(d(gen)); };

    std::generate(m_data, m_data+m_m*m_n, [&d, &gen] { return d(gen); });
}

Matrix::iterator Matrix::begin()
{
    return m_data;
}

Matrix::iterator Matrix::end()
{
    return m_data + m_m * m_n;
}

Matrix::const_iterator Matrix::cbegin() const
{
    return m_data;
}

Matrix::const_iterator Matrix::cend() const
{
    return m_data + m_m * m_n;
}
