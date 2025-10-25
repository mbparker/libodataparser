# libodataparser
A parser for OData queries that generates data model agnostic tree of objects that represent the query. These objects can be consumed directly for execution or mapped to expressions for use with an ORM.

Please note that this only implements filtering, sorting, and paging. The OData specs are quite large, and I did not require most of it. This library also adds some extra capability to the filters that is not in the spec.