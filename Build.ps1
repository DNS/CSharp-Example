
gci *.cs -File | %{ csc /nologo $_ /out:"bin\$($_.BaseName).exe" }

