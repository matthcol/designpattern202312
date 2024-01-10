#pragma once
#include <utility>
class IMatrix
{
public:
	virtual size_t m() const = 0;
	virtual size_t n() const = 0;
	virtual double operator[](std::pair<size_t, size_t> coords) const = 0;
	virtual double& operator[](std::pair<size_t, size_t> coords) = 0;
	virtual double sum(size_t row) const = 0;
	virtual ~IMatrix() = default;
};

