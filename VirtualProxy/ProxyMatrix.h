#pragma once
#include <memory>
#include "IMatrix.h"

class Matrix;

class ProxyMatrix: public IMatrix
{
public:
	ProxyMatrix(const std::shared_ptr<Matrix>& matrix);
	virtual ~ProxyMatrix();
	size_t m() const override;
	size_t n() const override;
	double operator[](std::pair<size_t, size_t> coords) const override;
	double& operator[](std::pair<size_t, size_t> coords) override;
	double sum(size_t row) const override;
private:
	mutable size_t m_row;
	size_t m_m;
	size_t m_n;
	mutable double* buffer;
	std::shared_ptr<Matrix> m_matrix;
	void load_row(size_t row) const;
};

