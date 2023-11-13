Feature: Language

A short summary of the feature

@AddLanguages
Scenario: [Adding Languages with valid inputs]
	Given [	I log in to the Mars page succesfully]
	And [I navigate to language page ]
	When [I add new language '<Languages>' '<level>']
	Then [Skill should be added succesfully '<Language>' '<level>' '<message> ]
	Examples:
	| Languages   |   Level      | Message                 |
	| Gujarati    | Fluent       | Gujarati has been added |
	| Hindi       | Native       | Hindi has been added    |

	@addinglanguagewithInvalidInputs
Scenario: [adding Language with duplicate data]
	Given [	I log in to the Mars page succesfully]
	And [I navigate to language page ]
	When [I add language with same name but different level '<Language>' '<level>']
	Then [gives error message '<duplicatedata>' ]
	Examples:
	| Language    |   Level        | Message        |
	| Gujarati    | Native      | Duplicate Data |

	@cancelandeditfunction@language
Scenario: [edit and cancel function]
	Given [	I log in to the Mars page succesfully]
	And [I navigate to skill page ]
	When [Click on edit button and cancel button]
	Then [record should be edit and cancel  ]