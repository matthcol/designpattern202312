template<class T>
class Iterator<T> {
        // TODO
}

template<class T>
class Iterable<T> {

public:
    virtual Iterator<T> begin() =0;
    virtual Iterator<T> end() =0;
}