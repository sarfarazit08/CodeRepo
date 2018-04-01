FROM alpine
MAINTAINER rickfast <rick.t.fast@gmail.com>
RUN apk update && apk add ruby
RUN gem install sinatra --no-ri --no-rdoc
RUN gem install redis --no-ri --no-rdoc
ADD counter.rb counter.rb
EXPOSE 4567
ENTRYPOINT ["ruby","counter.rb"]
