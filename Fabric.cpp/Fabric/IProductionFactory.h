#pragma once
#include "IMovie.h"
#include <memory>

class IProductionFactory
{
public:
	virtual std::shared_ptr<IMovie> createMovie(const std::string& title, uint16_t year) const = 0;
};

