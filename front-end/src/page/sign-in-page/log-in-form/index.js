import React from 'react'
import Form, {
    FormHeader,
    FormSection,
    FormFooter,
    Field,
  } from '@atlaskit/form';
import FieldText from '@atlaskit/field-text';
import Button from '@atlaskit/button';
import { Link } from 'react-router-dom'

export function LogInForm() {
    return (
        <Form>
            <FormHeader
                title="Sign in"
                description="Be ready to optimize your wardrobe"
            />
            <FormSection>
                <Field required>
                    <FieldText placeholder="Email adress.." />
                </Field>
                <Field required>
                    <FieldText placeholder="Password.." />
                </Field>

            </FormSection>
            <FormFooter>
                <div className="footer">
                    <Link to='/register'>I don't have an account</Link>
                    <Button appearance="primary">
                        Sign In
                    </Button>
                </div>
            </FormFooter>
        </Form>
    )
}