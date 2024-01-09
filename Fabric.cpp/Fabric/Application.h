#pragma once
#include "AbstractApplication.h"

class Application: public AbstractApplication
{
protected:
	virtual std::shared_ptr<IProductionFactory> productionFactoryInstance() const override;
};

