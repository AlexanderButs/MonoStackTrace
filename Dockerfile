FROM mono:5.18.1.3 as build
WORKDIR /src
COPY . .
RUN xbuild /p:Configuration=Release

FROM mono:5.18.1.3-slim AS final
WORKDIR /app
COPY --from=build /src .
#ENV MONO_LOG_LEVEL debug
ENTRYPOINT [ "mono", "--debug", "/app/MonoStackTrace/bin/Release/MonoStackTrace.exe" ]