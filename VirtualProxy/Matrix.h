#pragma once
#include <utility>
#include "IMatrix.h"
class Matrix: public IMatrix
{
public:
	Matrix(size_t m, size_t n);
	virtual ~Matrix();
	size_t m() const override;
	size_t n() const override;
	double operator[](std::pair<size_t,size_t> coords) const override;
	double& operator[](std::pair<size_t, size_t> coords) override;
	double sum(size_t row) const override;
	void fill_randomly();
	using iterator = double*;
	using const_iterator = const double*;
	iterator begin();
	iterator end();
	const_iterator cbegin() const;
	const_iterator cend() const;

private:
	double* m_data;
	size_t m_m;
	size_t m_n;
};

