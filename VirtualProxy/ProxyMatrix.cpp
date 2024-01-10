#include "ProxyMatrix.h"
#include "Matrix.h"
#include <algorithm>
#include <numeric>
#include <iostream>

ProxyMatrix::ProxyMatrix(const std::shared_ptr<Matrix>& matrix): 
	m_row(0), m_m(matrix->m()), m_n(matrix->n()), buffer(nullptr), m_matrix(matrix)
{
}

ProxyMatrix::~ProxyMatrix()
{
    if (buffer != nullptr) delete[] buffer;
}

size_t ProxyMatrix::m() const
{
    return m_m;
}

size_t ProxyMatrix::n() const
{
    return m_n;
}

double ProxyMatrix::operator[](std::pair<size_t, size_t> coords) const
{
    if ((buffer == nullptr) || (coords.first != m_row)) load_row(coords.first);
    return buffer[coords.second];
}

double& ProxyMatrix::operator[](std::pair<size_t, size_t> coords)
{
    if ((buffer == nullptr) || (coords.first != m_row)) load_row(coords.first);
    return buffer[coords.second];
}

double ProxyMatrix::sum(size_t row) const
{
    if ((buffer == nullptr) || (row != m_row)) load_row(row);
    return std::accumulate(buffer, buffer+m_n, 0.0);
}

void ProxyMatrix::load_row(size_t row) const
{
    if ((buffer != nullptr) && (row == m_row)) return; 
    if (buffer == nullptr) buffer = new double[m_n];
    auto first = m_matrix->cbegin() + row * m_n;
    std::copy(first, first+m_n, buffer);
    m_row = row;
    std::clog << "PROXY: load row #" << row << std::endl;
}
