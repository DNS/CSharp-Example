
gci *.cs -File | %{ csc /nologo $_ }
