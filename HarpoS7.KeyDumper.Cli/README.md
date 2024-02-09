# HarpoS7.KeyDumper.Cli

You can use this app to dump public keys used in legacy auth from a TIA Portal installation.
It works on all TIA Portal versions.

## Usage
1. Download the CLI
2. Run it (double-clicking it also works)
3. It will automatically find the TIA Portal installation and dump the keys to key-dump.json

### Help
You can set some options to change how to app works.

```shell
.\HarpoS7.KeyDumper.Cli.exe --help
----------------------------------

HarpoS7.KeyDumper.Cli 1.0.0+a61cc2ff1c002e3bd4c92170a5073b4f64815810
Copyright (C) 2024 HarpoS7.KeyDumper.Cli

  -t, --tia-portal     Dump keys from this TIA Portal installation directory

  -m, --mpk-file       Dump keys from this single MPK file

  -q, --quiet          Do not output anything to stdout

  -o, --output         The output file path containing dumped keys. Put in 'stdout' to output the JSON result to the
                       standard output

  -j, --indent-json    (Default: true) Whether or not to indent the resulting JSON

  -w, --do-not-wait    Whether or not to wait for a key press on exit

  --help               Display this help screen.

  --version            Display version information.
```