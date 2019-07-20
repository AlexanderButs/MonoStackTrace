FROM mono:5.18.1.3 as build
WORKDIR /src
COPY . .
RUN xbuild /p:Configuration=Release

FROM mono:5.18.1.3 AS final
WORKDIR /app
COPY --from=build /src .
# ENTRYPOINT [ "mono", "--debug", "/app/MonoStackTrace/bin/Release/MonoStackTrace.exe" ]