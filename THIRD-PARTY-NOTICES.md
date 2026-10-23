# Third-party notices

The decoded legacy seed algorithms and fingerprint SPN constants are based on the
recovery documented by Gijs Molenaar and contributors in
[gijzelaerr/s7commplus](https://github.com/gijzelaerr/s7commplus/tree/826fc9cc7975eac7763c5ae2325cfeca51c8f28d),
commit `826fc9cc7975eac7763c5ae2325cfeca51c8f28d`, shared in
[HarpoS7 issue #28](https://github.com/bonk-dev/HarpoS7/issues/28).
The C# implementation uses that project's recovered PRESENT key schedule,
elliptic-curve parameters, seed plaintexts, and fingerprint keys and wiring.
Its MIT license follows.

The MIT License (MIT)

Copyright (c) 2013 Gijs Molenaar, Stephan Preeker

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
