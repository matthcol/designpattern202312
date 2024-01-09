#pragma once
#include <memory>
#include "IProductionFactory.h"

class AbstractApplication
{
public:
	void run();
protected:
	virtual std::shared_ptr<IProductionFactory> productionFactoryInstance() const = 0;
private:
	void watchMovies();
};

