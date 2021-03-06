# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Advisor
  module Models
    #
    # The list of Advisor recommendations.
    #
    class ResourceRecommendationBaseListResult
      # @return [String] The link used to get the next page of recommendations.
      attr_accessor :next_link

      # @return [Array<ResourceRecommendationBase>] The list of
      # recommendations.
      attr_accessor :value


      #
      # Mapper for ResourceRecommendationBaseListResult class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          required: false,
          serialized_name: 'ResourceRecommendationBaseListResult',
          type: {
            name: 'Composite',
            class_name: 'ResourceRecommendationBaseListResult',
            model_properties: {
              next_link: {
                required: false,
                serialized_name: 'nextLink',
                type: {
                  name: 'String'
                }
              },
              value: {
                required: false,
                serialized_name: 'value',
                type: {
                  name: 'Sequence',
                  element: {
                      required: false,
                      serialized_name: 'ResourceRecommendationBaseElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'ResourceRecommendationBase'
                      }
                  }
                }
              }
            }
          }
        }
      end
    end
  end
end
